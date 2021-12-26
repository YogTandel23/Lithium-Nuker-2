﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LithiumNukerV2
{
    public static class Settings
    {
        public static bool Debug = false;

        public static readonly string Logo = @"
          ▒▒▒▒            ░▒▒▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒      ▒░▒▒▒      ▒▒▒                                 ▒░░░▒
          ▒▒██▒         ▒▒▒▒▒░▒███████████████████░▒▒▒▒▒▒▒████▒     ▒▒▒█▒       ▒▒▒     ▒▒     ▒ ▒      ▒████▒
        ▒█████▒        ▒████▒   ▒▒▒▒▒█████▒▒       ▒▒░▒▒▒▒████▒    ▒████▒    ░▒▒░░▒   ▒░█▒   ▒░▒░▒      ▒████▒
       ▒█████▒        ▒▒████▒      ░▒████▒▒      ▒░███▒▒▒█████▒   ▒▒████▒   ▒████▒   ▒██▒▒  ▒▒███▒▒    ▒████▒▒
      ▒▒████▒         ▒████▒▒      ▒████░▒      ▒░████▒▒▒████▒    ▒████▒▒   ▒███▒  ▒▒███▒   ▒█████▒ ▒▒█████▒▒
     ░▒████▒          ▒████▒      ▒▒████▒   ▒▒▒░█████▒▒▒████▒▒    ▒████▒  ▒▒███▒▒  ▒████▒   ▒█████▒▒██████▒▒
     ▒░████▒         ░▒███▒       ▒███░▒   ▒▒▒░████████████▒▒▒▒  ▒▒███▒   ▒████▒  ▒█████▒  ▒░████████████▒▒
     ▒████▒          ▒▒███▒      ▒░███▒▒      ▒████▒▒▒▒████▒▒▒   ▒▒██░▒   ▒███▒  ▒▒████▒   ▒███▒▒███▒▒███▒
  ▒▒▒█████▒▒░░░▒░█░▒▒▒███▒       ▒▒██▒▒      ░▒███▒  ▒███▒▒      ▒███▒    ▒███▒ ▒▒████▒   ▒▒███▒▒▒█▒░▒██▒▒
 ░ ░▒█████████████░▒▒▒██▒▒       ▒███▒       ▒███▒▒  ▒███▒       ▒██▒▒    ▒░█████████▒▒   ▒██▒▒▒░▒▒▒▒▒█▒▒
   ▒▒▒░░▒▒▒▒▒▒       ▒░▒▒        ▒░██▒       ▒██░▒   ▒██▒░       ▒░▒░       ▒░█████░▒     ▒█▒       ▒░▒▒
                    ▒░▒          ▒▒█▒        ▒█▒▒   ▒░▒▒        ▒▒▒                                 ▒▒▒
                                 ▒░▒▒       ▒▒▒     ▒▒░
                                 ▒▒▒";
        public static string Token;
        public static long GuildId;
        public static string WebhookName;
        public static readonly int Threads = 30;
        public static readonly int ConnectionLimit = 25; // 25 connections
        public static readonly string AvatarUrl = "https://camo.githubusercontent.com/450b75468a748fbd8e4b3116c378cc9cfdcadd8b0b0e676821a6f873fcb85f53/68747470733a2f2f7665726c6f782e63632f7261772f535865475144";
    }
}