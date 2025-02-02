// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeServerEventResponseFunctionCallArgumentsDone : ConversationUpdate
    {
        internal InternalRealtimeServerEventResponseFunctionCallArgumentsDone(string eventId, string responseId, string itemId, int outputIndex, string callId, string arguments) : base(eventId)
        {
            Argument.AssertNotNull(eventId, nameof(eventId));
            Argument.AssertNotNull(responseId, nameof(responseId));
            Argument.AssertNotNull(itemId, nameof(itemId));
            Argument.AssertNotNull(callId, nameof(callId));
            Argument.AssertNotNull(arguments, nameof(arguments));

            Kind = ConversationUpdateKind.ItemStreamingFunctionCallArgumentsFinished;
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            CallId = callId;
            Arguments = arguments;
        }

        internal InternalRealtimeServerEventResponseFunctionCallArgumentsDone(ConversationUpdateKind kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string responseId, string itemId, int outputIndex, string callId, string arguments) : base(kind, eventId, serializedAdditionalRawData)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            CallId = callId;
            Arguments = arguments;
        }

        internal InternalRealtimeServerEventResponseFunctionCallArgumentsDone()
        {
        }

        public string ResponseId { get; }
        public string ItemId { get; }
        public int OutputIndex { get; }
        public string CallId { get; }
        public string Arguments { get; }
    }
}
