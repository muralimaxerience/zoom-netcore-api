using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Models.Meetings
{
    public class RecordingFile : BaseObject
    {
        public string DownloadUrl { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
        public string MeetingId { get; set; }
        public string PlayUrl { get; set; }
        public string RecordingEnd { get; set; }
        public string RecordingStart { get; set; }
        public string RecordingType { get; set; }
        public string Status { get; set; }
    }
    public class MeetingRecording : BaseObject
    {
        public string AccountId { get; set; }

        public int Duration { get; set; }

        public string HostId { get; set; }

        public int RecordingCount { get; set; }

        public List<RecordingFile> RecordingFiles { get; set; }

        public string ShareUrl { get; set; }

        public string StartTime { get; set; }

        public string Timezone { get; set; }

        public string Topic { get; set; }

        public int TotalSize { get; set; }

        public int Type { get; set; }

        public string Uuid { get; set; }
    }
}