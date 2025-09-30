using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atonix.Classes
{
    public class RPCClass
    {
        public static DiscordRpcClient Client;
        public static Timestamps TimeStamps { get; set; }
        private static RichPresence Rpc;

        public static void InitializeRPC()
        {
            Client = new DiscordRpcClient("1027661581439467620");
            Client.Initialize();

            Button[] AXButtons =
            {
                new Button() { Label = "Download", Url = "https://link-target.net/546033/atonixv156b" },
                new Button() { Label = "Join Discord", Url = "https://discord.gg/T7kVZ4rZnU" }
            };

            Rpc = new RichPresence()
            {
                Buttons = AXButtons,
                Timestamps = TimeStamps,
                Details = "https://dsc.gg/atonix",

                Assets = new Assets()
                {
                    LargeImageKey = "atonix",
                    LargeImageText = "unsyncedmaster",
                }
            };
            SetState("Scripting With Atonix!");
        }
        public static void SetState(string state)
        {
            Rpc.State = state;
            Client.SetPresence(Rpc);
        }
        public static void DisposeRPC()
        {
            Client.Dispose();
        }
    }
}
