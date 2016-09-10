﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Werewolf_Control.Models
{
    public class GetStatusInfo
    {
        public string JType { get; set; } = "GetStatusInfo";
    }

    public class StatusResponseInfo
    {
        public string JType { get; set; } = "StatusResponseInfo";
        public string BotName { get; set; }
        public int NumGames { get; set; }
        public int NumPlayers { get; set; }
        public TimeSpan Uptime { get; set; }
        public List<Guid> NodeIds { get; set; }
        public long MessagesPerSecondIn { get; set; }
        public long MessagesPerSecondOut { get; set; }
        public string Status { get; set; }
        public int MaxGames { get; set; }
        public DateTime MaxGamesTime { get; set; }
    }

    public class GetNodeInfo
    {
        public string JType { get; set; } = "GetNodeInfo";
        public Guid ClientId { get; set; }
    }

    public class NodeResponseInfo
    {
        public string JType { get; set; } = "NodeResponseInfo";
        public Guid ClientId { get; set; }
        public int CurrentGames { get; set; }
        public int CurrentPlayers { get; set; }
        public TimeSpan Uptime { get; set; }
        public HashSet<GameInfo> Games { get; set; } = new HashSet<GameInfo>();
        public string Version { get; set; }
        public bool ShuttingDown { get; set; }
        public int MessagesSent { get; set; }
    }
}
