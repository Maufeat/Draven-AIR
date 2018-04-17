namespace Draven.Redirector.Properties
{
    class DravenProperties
    {
        private string _host = Program.RTMPSHost;
        private string _xmpp_server_url = "192.168.178.20";//"chat.oc1.lol.riotgames.com";
        private string _lq_uri = "http://" + Program.RTMPSHost + ":8080";//"https://lq.oc1.lol.riotgames.com";
        private string _lobbyLandingURL = "http://25.120.134.146:8080";
        private string _featuredGamesURL = "http://25.120.134.146:8080/observer-mode";//"http://spectator.oc1.lol.riotgames.com:80/observer-mode/rest/featured";

        //-------------------------------------------------------------------------------------

        public string host { get { return _host; } set { _host = value; } }

        public string xmpp_server_url { get { return _xmpp_server_url; } set { _xmpp_server_url = value; } }

        public string ladderURL { get { return "http://www.leagueoflegends.com/ladders"; } }

        public string storyPageURL { get { return "http://www.leagueoflegends.com/story"; } }

        public string lq_uri { get { return _lq_uri; } set { _lq_uri = value; } }

        public string ekg_uri { get { return "https://ekg.riotgames.com"; } }

        public string rssStatusURLs { get { return "null"; } }

        public string lobbyLandingURL { get { return _lobbyLandingURL; } set { _lobbyLandingURL = value; } }

        public string loadModuleChampionDetail { get { return "true"; } }

        public string featuredGamesURL { get { return _featuredGamesURL; } set { _featuredGamesURL = value; } }

        public string riotDataServiceDataSendProbability { get { return "1.0"; } }

        public string platformId { get { return "EUW1"; } }

        public string regionTag { get { return "euw"; } }
    }
}
