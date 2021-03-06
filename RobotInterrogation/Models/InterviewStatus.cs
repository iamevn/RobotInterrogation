﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RobotInterrogation.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InterviewStatus
    {
        WaitingForConnections,
        SelectingPositions,

        SelectingPenalty_Interviewer,
        SelectingPenalty_Suspect,

        SelectingPacket,

        SelectingRole,
        SelectingSuspectNote,

        ReadyToStart,

        InProgress,

        Finished,
    }
}