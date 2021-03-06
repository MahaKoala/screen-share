﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using vtortola.WebSockets;

namespace UlteriusScreenShare.Websocket
{
    internal class AuthClient
    {
        public AuthClient(WebSocket client)
        {
            Client = client;
            Started = DateTime.Now;
            Authenticated = false;
            AesShook = false;
            ReceivedFullFrame = false;
        }

        public WebSocket Client { get; set; }
        public DateTime Started { get; set; }
        public bool Authenticated { get; set; }
        public SecureString PrivateKey { get; set; }
        public SecureString PublicKey { get; set; }
        public SecureString AesKey { get; set; }
        public SecureString AesIv { get; set; }
        public bool AesShook { get; set; }
        public bool ReceivedFullFrame { get; set; }
    }

}
