﻿using System.Collections.Generic;

namespace Concepts.Mediator
{
    public class Chatroom : AbstractChatroom
    {
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            participant?.Receive(from, message);
        }
    }
}
