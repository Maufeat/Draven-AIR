namespace Draven.AuthServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using Draven.DatabaseManager;

    using Newtonsoft.Json;

    public class AuthServer
    {
        private readonly HttpListener _listener = new HttpListener();
        private readonly Func<HttpListenerRequest, Task<object>> _responderMethod;

        public AuthServer(Func<HttpListenerRequest, Task<object>> method, params string[] prefixes)
        {
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");
            foreach (string s in prefixes)
                _listener.Prefixes.Add(s);

            _responderMethod = method ?? throw new ArgumentException("method");
        }

        public void Start()
        {
            _listener.Start();

            ThreadPool.QueueUserWorkItem((o) =>
            {
                while (_listener.IsListening)
                {
                    try
                    {
                        HttpListenerContext context = _listener.GetContext();
                        context.Response.Headers[HttpResponseHeader.ContentType] = SetContentType(context.Request.RawUrl);

                        Task<object> responseTask = _responderMethod(context.Request);
                        Task.WaitAny(responseTask);
                        object response = responseTask.Result;
                        byte[] buf;

                        if (response is string[])
                        {
                            string[] temp = response as string[];
                            response = temp[0];
                            context.Response.StatusCode = Convert.ToInt32(temp[1]);
                            buf = Encoding.UTF8.GetBytes((string)response);
                        }
                        else if (response is string)
                            buf = Encoding.UTF8.GetBytes((string)response);
                        else
                            buf = (byte[])response;

                        context.Response.ContentLength64 = buf.Length;
                        using (var Stream = context.Response.OutputStream)
                        {
                            Stream.Write(buf, 0, buf.Length);
                        }
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                }
            });
        }

        public static string SetContentType(string RawUrl)
        {
            if (RawUrl.EndsWith(".png"))
                return "image/png";
            else if (RawUrl.EndsWith(".jpg"))
                return "image/jpeg";
            else if (RawUrl.EndsWith(".css"))
                return "text/css";
            else if (RawUrl.EndsWith(".js"))
                return "text/javascript";
            else if (RawUrl.EndsWith("/") || RawUrl.EndsWith(".html"))
                return "text/html";

            return "application/json";
        }

        public static async Task<object> HandleWebServ(HttpListenerRequest request)
        {
            Console.WriteLine("[LOG] Get Request for: " + request.RawUrl);
            if (request.RawUrl == ("/login-queue/rest/queues/lol/authenticate"))
            {
                string[] response = { "", "" };
                try
                {
                    //string Username = request.InputStream["user"];
                    using (System.IO.Stream body = request.InputStream) // here we have data
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(body, request.ContentEncoding))
                        {
                            string payloader = Uri.UnescapeDataString(reader.ReadToEnd()).Substring(8);
                            string username = payloader.Split(',')[0].Split('=')[1];
                            string password = payloader.Split(',')[1].Split('=')[1];
                            if (DatabaseManager.checkAccount(username, password))
                            {
                                Dictionary<string, string> data = DatabaseManager.getAccountData(username, password);
                                if (data["banned"] == "1")
                                {
                                    response[1] = "403";
                                    response[0] = "{\"rate\":0,\"reason\":\"account_banned\",\"status\":\"FAILED\",\"delay\":5000,\"banned\":7357299742000}";
                                }
                                else
                                {
                                    response[1] = "200";
                                    response[0] = "{\"rate\":150,\"token\":\"fake\",\"reason\":\"login_rate\",\"status\":\"LOGIN\",\"delay\":5000,\"inGameCredentials\":{\"inGame\":true,\"summonerId\":null,\"serverIp\":null,\"serverPort\":null,\"encryptionKey\":null,\"handshakeToken\":null},\"user\":\"" + username + "\",\"idToken\":\"eyJhbGciOiJSUzI1NiJ9.eyJsb2wiOlt7InVpZCI6MjA3NDEwOTAyLCJjdWlkIjoyMDc0MTA5MDIsInVuYW1lIjoiZ3VzdGw4NiIsImNwaWQiOiJFVVcxIiwicGlkIjoiRVVXMSJ9XSwiZXhwIjoxNDYwMzIzODI0LCJzdWIiOiJlNDgzMDAwOC1lNmM0LTUxZDMtOTRmNS1kMGY1Zjg2NDc1YmQiLCJ0YWciOltdLCJhdWQiOiJsb2wiLCJpc3MiOiJodHRwczpcL1wvZ2FzLnJpb3RnYW1lcy5jb20iLCJpYXQiOjE0NjAyMzc0MjQsImFtciI6ImNsaWVudF9iYXNpYyJ9.L8jShMcK4B_qRjoC2VB1UNrDhF_JB6jHLPuMu5M48vrAyxb6oFl_n5ny_a9fQ9789W69OfNDneG0zzfC4qZQfa6VfKyyVO_1N9v93jcwVbpKku57QcVD8Fsn_eBYCwc2PkGpRahOlCuzdQLJ16zQBNuY3K2Q8-mx7HnAoxZTzza08IchtuzttQfq396NDkSEB99l37q5l1Xd0HlUX8o-quJzrlz9Gxfiy9k8c8CY-G1sobxlVTtr85_s9HDlBWlCW14Sxo2dXsUZuW3W2P0ih4vkh8GxGG_HhOmJhPktZiVkcEAEXGd_sluMld6RBRwBvY1N6KCClUvsFMRjWG85Rg\",\"gasToken\":{\"vouching_key_id\":\"ae226c904afe157360229b814d4e3749\",\"gas_account_id\":\"207410902\",\"signature\":\"RfOlM9omdxGtcLqV3xXmB/xLcjRcZw3lrZt1zpsFkY8YkKLbaiVrTD0nmksnYCL9dZbSyuExGGYmT4AChpzAIJlEY5IMWUgoNMC76TExg2oE8Ho8YEQDlMiac+UdhwVltR3VB/itgik/3Exh6mumt+G8RJlcV1HpYV1tPV8rzKgeInPSrGrowKaptnNAR9TJHUIh2OiABgI37P36xrUcHT3liTCl7WcWFlnn16/qEIY/1hvxiAztJOu6NYIUlqEor4w+Jb0gtKP5ZxMDnyKkpqZlhcfU6pzJ/JDtYN+LqIRks47d7S2nVfamrb43c6zgufhRYZIh2NmIB8cbCxvWfQ==\",\"summoner_name\":null,\"date_time\":1460237424652,\"pvpnet_account_id\":207410902}}";
                                }
                            }
                            else
                            {
                                response[1] = "403";
                                response[0] = "{\"rate\":0,\"reason\":\"invalid_credentials\",\"status\":\"FAILED\",\"delay\":5000}";
                            }
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                //Console.WriteLine(response);
                return response;
            }
            else if (request.RawUrl.StartsWith("/api"))
            {
                return await HandleAPI(request);
            }
            else
            {

                string ReadURL = request.RawUrl;
                if (ReadURL == "/")
                    ReadURL = "/index.html";
                if (ReadURL == "/favicon.ico")
                    return "";

                string ContentType = AuthServer.SetContentType(request.RawUrl);
                string RequestedFile = ReadURL.Split('/').Last();

#if !FILESYSTEM
                /*using (var db = new LiteEngine("poro.dat"))
                {
                    var file = db.FileStorage.FindById(RequestedFile);

                    if (file == null)
                        return "404";

                    var stream = file.OpenRead();

                    using (var memoryStream = new MemoryStream())
                    {
                        stream.CopyTo(memoryStream);
                        byte[] bytes = memoryStream.ToArray();
                        if (ContentType.StartsWith("image"))
                        {
                            return bytes;
                        }
                        else
                        {
                            return Encoding.Default.GetString(bytes);
                        }
                    }
                }*/
                //return "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01//EN\">\r\n<html>\r\n\t<head>\r\n\t\t<title>Child Title</title>\r\n\t\t<style>\r\n\t\t\tbody { \r\n\t\t\t\tbackground-color: #000000;\r\n\t\t\t\tfont-family: Georgia, \"Times New Roman\", Times, serif; font-weight: bold; color: #ffffff;\r\n\t\t\t}\r\n\t\t</style>\r\n\t</head>\r\n\t\r\n\t<script>\r\n\t\r\n\t\tvar childInterface = {};\r\n\t\tchildInterface.childId = \"abc\" \r\n\t\twindow.childSandboxBridge = childInterface;\r\n\t\t\r\n\t\tchildInterface.childSetupBridge = function() {\r\n\t\t\tvar log = document.getElementById(\"log\"); \r\n\t\t\tlog.innerHTML += window.parentSandboxBridge.testProperty + \"<br/>\";\t\t\t\r\n\t\t}\r\n\t\t\r\n\t\tchildInterface.updateStatus = function() {\r\n\t\t\t\tsetAJAXHttpStatus(25);\r\n\t\t\t}\r\n\r\n\t\t\tchildInterface.setChildProperty = function(text) {\r\n\t\t\t\tvar log = document.getElementById(\"log\"); \r\n\t\t\t\tlog.innerHTML += text + \"<br/>\";\t\t\t\r\n\t\t\t}\r\n\r\n\t\tfunction openInventoryBrowser(fullItemId) {\r\n\t\t\twindow.parentSandboxBridge.openInventoryBrowser(fullItemId);\t\t\t\r\n\t\t}\r\n\t\t\t\r\n\t\tfunction setAJAXHttpStatus(value) {\r\n\t\t\twindow.parentSandboxBridge.setAJAXHttpStatus(value);\t\t\t\r\n\t\t}\r\n\t\t\r\n\t\tfunction playChooseMe(skinName) {\r\n\t\t\twindow.parentSandboxBridge.playChooseMe(skinName);\t\t\t\r\n\t\t}\r\n\t\t\r\n\t\t \t\t\r\n\t</script>\r\n\t\r\n\t<body>\r\n\t\t<h2>\r\n\t\t\tTest Sandbox Take 178\r\n\t\t</h2>\r\n\t\t<button type=\"button\" onclick=\"setAJAXHttpStatus(52);\">set ajax status</button>\r\n\t\t<button type=\"button\" onclick=\"openInventoryBrowser(22);\">open inventory browser</button>\r\n\t\t<button type=\"button\" onclick=\"playChooseMe('Bowmaster');\">play sound</button>\r\n\t\t<p>\r\n\t\t<div id=\"log\" style=\"width: 450px; height: 400px; overflow-y: scroll;\" /> \r\n\t\t</p>\r\n\t\t<p>\r\n\t\t\t<img src=\"/img/content/champions/Bowmaster.png\" alt=\"\">\r\n\t\t</p>\r\n\t</body>\r\n</html>\r\n";
                return "<html><head><meta charset=\"utf-8\"><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><title>LoL Lobby</title><base target=\"_blank\"><link rel=\"stylesheet\" href=\"https://lolstatic-a.akamaihd.net/frontpage/apps/prod/lol_client/de_DE/18f69d3ef970a03a43c86181a3d620f12ac208f6/assets/css/lk3.css\"><script type=\"text/javascript\">var childInterface = {};var spectateDataURL;window.childSandboxBridge = childInterface;if (typeof window.parentSandboxBridge !== \'undefined\') {window.parentSandboxBridge.loaded();window.location.clientAssetPath = window.parentSandboxBridge.clientAssetPath;}spectateDataURL = window.parentSandboxBridge.featuredGamesURL;var locale = \'de_DE\';var versionedAssetPath = \'https://lolstatic-a.akamaihd.net/frontpage/apps/prod/lol_client/de_DE/18f69d3ef970a03a43c86181a3d620f12ac208f6/assets\';var templateVersion = \'18f69d3ef970a03a43c86181a3d620f12ac208f6\';var pagesBasePath = \'https://lolstatic-a.akamaihd.net/frontpage/apps/prod/lol_client/de_DE/18f69d3ef970a03a43c86181a3d620f12ac208f6\';var assetMagickPath = \'https://am-a.akamaihd.net\';/*@TODO: construct templateReferenceBase on the server side, and pass it along with the contextso that the build process can own the definition of how to reference templates.*/var templateReferenceBase = \'lol_client/\' + locale + \'/\' + templateVersion;/*set a default for assetMagickPath, so we don\'t break staging before Harbinger changes get depolyed.*/if (assetMagickPath === \'\') {assetMagickPath = \'https://am-a.akamaihd.net\';}(function() {var rs = document.createElement(\'script\');rs.type = \'text/javascript\';rs.setAttribute(\'data-main\', \'https://lolstatic-a.akamaihd.net/frontpage/apps/prod/lol_client/de_DE/18f69d3ef970a03a43c86181a3d620f12ac208f6/assets/js/main-require.js\');rs.src = window.location.clientAssetPath + \'/htmlTemplates/js/require-2.1.11.min.js\';document.getElementsByTagName(\'head\')[0].appendChild(rs);})();</script><script type=\"text/javascript\">var clientLocale;var clientRegion;var summonerInfo;var gasToken;var accountId;if (typeof window.parentSandboxBridge !== \'undefined\'){clientLocale = window.parentSandboxBridge.locale || \'unknown\';clientRegion = window.parentSandboxBridge.region;if (typeof window.parentSandboxBridge.getSummonerInfo === \'function\') {summonerInfo = window.parentSandboxBridge.getSummonerInfo();gasToken = JSON.parse(summonerInfo.summonerGasToken);accountId = gasToken.pvpnet_account_id;}}window.pCfg = {appname: \'lol_client\',meta: {locale: clientLocale}};if (typeof accountId !== \'undefined\') {pCfg.account = {locale: clientLocale,region: clientRegion,accountId: accountId};}</script></head><body id=\"frontpage\" class=\"i18n-de_DE landing-oembeds\" data-rodeo-concurrency=\"false\" data-lasso-endpoint=\"https://oembed.leagueoflegends.com/oembed\"><div class=\"cbox cbox-r-client\"><div class=\"gsc-fill margin-small\"><div class=\"gsc gsc-fill gsc-gutter-small\"><div class=\"gst w-2-3 h-2-3\"><lasso-embed url=\"http://news-oembed.leagueoflegends.com/v1/euw/de/news/landing-page/uuid/90cf3c12-f005-454e-a8ea-5b3f553a46a8?viewMode=card-tier-1\"></lasso-embed></div><div class=\"gst w-1-3 h-1-3 l-2-3\"><div class=\"gsc gsc-fill gsc-gutter-small\"><div class=\"gst w-1-2 h-1-1\"><div class=\"ct-wr ct-t-store ct-s-card tier-3\" data-ping-meta=\"cardTier=3|cardType=store\"><div class=\"ct-bd\"><img class=\"store-image-portrait\" data-client-image-src=\"/images/champions/Lissandra_3.jpg\" /></div><div class=\"gsc-fill\"><div class=\"overlay pos-bottom\"><h2 class=\"ct-title stacktext\">Programm Lissandra</h2><div class=\"item-cost\"><span class=\"cost-rp\">1350</span></div></div></div><a class=\"gsc-fill action store-unlock\" data-air-navigate-json=\"{&quot;type&quot;:&quot;store&quot;, &quot;relativeUrl&quot;:&quot;/store/tabs/view/skins&quot;, &quot;queryString&quot;:&quot;showItemId=championsskin_127003&quot; }\" data-analytics-event=\"store:unlock\"></a></div></div><div class=\"gst w-1-2 h-1-1 l-1-2\"><div class=\"ct-wr ct-t-store ct-s-card tier-3\" data-ping-meta=\"cardTier=3|cardType=store\"><div class=\"ct-bd\"><img class=\"store-image-portrait\" data-client-image-src=\"/images/champions/Soraka_6.jpg\" /></div><div class=\"gsc-fill\"><div class=\"overlay pos-bottom\"><h2 class=\"ct-title stacktext\">Programm Soraka</h2><div class=\"item-cost\"><span class=\"cost-rp\">1350</span></div></div></div><a class=\"gsc-fill action store-unlock\" data-air-navigate-json=\"{&quot;type&quot;:&quot;store&quot;, &quot;relativeUrl&quot;:&quot;/store/tabs/view/skins&quot;, &quot;queryString&quot;:&quot;showItemId=championsskin_16006&quot; }\" data-analytics-event=\"store:unlock\"></a></div></div></div></div><div class=\"gst w-1-3 h-1-3 l-2-3 t-1-3\"><lasso-embed url=\"http://news-oembed.leagueoflegends.com/v1/euw/de/news/landing-page/uuid/44f06393-f567-4481-aea5-9e46d1d533a5?viewMode=card-tier-2\"></lasso-embed></div><div class=\"gst w-1-3 h-1-3 t-2-3\"><lasso-embed url=\"http://news-oembed.leagueoflegends.com/v1/euw/de/news/landing-page/uuid/75dd4c82-e3d1-4211-9689-95edd9c1cf2d?viewMode=card-tier-2\"></lasso-embed></div><div class=\"gst w-1-3 h-1-3 l-1-3 t-2-3\" data-player-survey=\"50\"><lasso-embed url=\"http://news-oembed.leagueoflegends.com/v1/euw/de/news/landing-page/uuid/d93fe2ef-de21-4251-a523-56f46d3c1e0f?viewMode=card-tier-2\"></lasso-embed></div><div class=\"gst w-1-3 h-1-3 l-2-3 t-2-3\"><lasso-embed url=\"http://news-oembed.leagueoflegends.com/v1/euw/de/news/landing-page/uuid/68dcc063-c318-446e-b747-5e68a78d000f?viewMode=card-tier-2\"></lasso-embed></div></div></div></div><script type=\"text/javascript\" src=\"https://lolstatic-a.akamaihd.net/ping/ping-0.1.238.min.js\"></script><script type=\"text/javascript\">(function(){window.addEventListener(\'error\', errorHandler);window.addEventListener(\"load\", function() {var elements = document.getElementsByTagName(\'link\');for (var i = 0; i < elements.length; i++) {var element = elements[i];if (element.rel == \'stylesheet\') {var elementRules = element.sheet.rules;if (elementRules && elementRules.length == 0) {notifyPageError(\'STYLESHEET\', element.href);}}}});function getTargetErrorDescription(element) {if (element.nodeName == \"SCRIPT\") {return element.src;}else {var estr = \"\";for (var p in element) {if (element.hasOwnProperty(p)) {estr += \" | \" + p + \": \" + element[p];}}return estr;}}function errorHandler (err) {notifyPageError(err.target.nodeName, getTargetErrorDescription(err.target));}window.notifyPageError = function notifyPageError(type, message) {/*alert(\'Error: type:\' + type + \' message: \' + message);*/window.ping(\'error\', {\'meta.error_type\': type,\'meta.error_message\': message});}})();</script><script type=\"text/javascript\" src=\"https://lolstatic-a.akamaihd.net/lassojs/0.1.4/lasso.js\"></script><script>(function(i,s,o,g,r,a,m){i[\'GoogleAnalyticsObject\']=r;i[r]=i[r]||function(){(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)})(window,document,\'script\',\'//www.google-analytics.com/analytics.js\',\'ga\');ga(\'create\', \'UA-5859958-26\', \'leagueoflegends.com\');ga(\'send\', \'pageview\');</script></body></html>";
#endif

#if FILESYSTEM
                //Uncomment to create poro.dat
                /*var x = File.OpenRead(FileURL);
                using (var db = new LiteEngine("poro.dat"))
                {
                    var file = db.FileStorage.FindById(RequestedFile);

                    if (file == null)
                    {
                        db.FileStorage.Upload(RequestedFile, x);
                    }
                }*/

                string FileURL = string.Format("app/web{0}", ReadURL);

                if (ContentType.StartsWith("image"))
                {
                    return File.ReadAllBytes(FileURL);
                }
                else
                {
                    return File.ReadAllText(FileURL);
                }
#endif
            }
        }

        public static async Task<object> HandleAPI(HttpListenerRequest request)
        {
            if (request.RawUrl.StartsWith("/api/users"))
            {
                using (System.IO.Stream body = request.InputStream) // here we have data
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(body, request.ContentEncoding))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
                return null;
            }
            else if (request.RawUrl.StartsWith("/api/register"))
            {
                //if (request.QueryString == null && request.QueryString.Count != 4)
                return "400";

                /*_users.AddUser(new User
                {
                    Username = request.QueryString["Username"],
                    Password = request.QueryString["Password"],
                    Region = request.QueryString["Region"],
                    SummonerName = request.QueryString["Username"]
                });
                return JsonConvert.SerializeObject(_users.GetUserList());*/
            }
            else if (request.RawUrl.StartsWith("/api/delete"))
            {
                //if (request.QueryString == null && request.QueryString.Count != 2)
                return "400";

                /*User u = _users.GetUser(request.QueryString["Username"], request.QueryString["Region"]);
                _users.RemoveUser(u);*/

                //return JsonConvert.SerializeObject(_users.GetUserList());
            }
            else if (request.RawUrl.StartsWith("/api/regions"))
            {
                //return JsonConvert.SerializeObject(Shards.GetStatus());
                return "400";
            }
            else if (request.RawUrl.StartsWith("/api/login"))
            {
                if (request.QueryString == null && request.QueryString.Count != 2)
                    return "400";

                string Username = request.QueryString["Username"];
                string Region = request.QueryString["Region"];

                Console.WriteLine("Username: " + Username + " Region: " + Region);
                return await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
                /*var ShardList = Shards.GetInstances<BaseShard>();
                BaseShard shard = null;
                foreach (BaseShard s in ShardList)
                    if (s.Name == Region)
                        shard = s;

                User user = _users.GetUser(Username, Region);
                ForwardPlayer player = new ForwardPlayer(user, shard, _context);
                bool Connected = await player.Connect();

                foreach (RtmpClient client in _server._clients)
                {
                    StoreAccountBalanceNotification notification = new StoreAccountBalanceNotification
                    {
                        IP = player._packet.IpBalance,
                        RP = player._packet.RpBalance
                    };

                    client.InvokeDestReceive("cn-1", "cn-1", "messagingDestination", notification);
                }

                _forwarder.Assign(player);

                Console.WriteLine(string.Format("[LOG] Forwarding to {0} ({1})", Username, Region));*/

                //return JsonConvert.SerializeObject("OK");
            }
            else if (request.RawUrl.StartsWith("/api/check"))
            {
                return JsonConvert.SerializeObject("Not logged in");
            }
            else
            {
                return "404";
            }
        }

    }
}
