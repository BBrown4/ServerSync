using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace ServerSync.Server
{
    public class ServerTime : BaseScript
    {
        private DateTime _date = DateTime.Now;
        private int _secondOfDay = 7 * 3600 + 30 * 60 + 0;
        private bool _frozen = false;
        
        public ServerTime()
        {
            EventHandlers["freezeTime"] += new Action(ToggleFreezeTime);
            EventHandlers["addTimeChatSuggests"] += new Action<string, string>(OnAddTimeChatSuggests);
        }

        private void OnAddTimeChatSuggests(string source, string obj)
        {
            if (API.IsPlayerAceAllowed(source, "changeTime"))
            {
                TriggerClientEvent("addTimeChatSuggests", source);
            }
        }

        private void ToggleFreezeTime()
        {
            _frozen = !_frozen;
        }
    }
}