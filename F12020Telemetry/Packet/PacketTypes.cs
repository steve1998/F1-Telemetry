﻿namespace F12020Telemetry.Packet
{
    public enum PacketTypes : byte
    {
        /// <summary>
        /// Contains all motion data for player’s car – only sent while player is in control
        /// </summary>
        Motion,

        /// <summary>
        /// Data about the session – track, time left
        /// </summary>
        Session,

        /// <summary>
        /// Data about all the lap times of cars in the session
        /// </summary>
        LapData,

        /// <summary>
        /// Various notable events that happen during a session
        /// </summary>
        Event,

        /// <summary>
        /// List of participants in the session, mostly relevant for multiplayer
        /// </summary>
        Participants,

        /// <summary>
        /// Packet detailing car setups for cars in the race
        /// </summary>
        CarSetups,

        /// <summary>
        /// Telemetry data for all cars
        /// </summary>
        CarTelemetry,

        /// <summary>
        /// Status data for all cars such as damage
        /// </summary>
        CarStatus,

        /// <summary>
        /// Final classification confirmation at the end of a race
        /// </summary>
        FinalClassification,

        /// <summary>
        /// Information about players in a multiplayer lobby
        /// </summary>
        LobbyInfo,
    }
}