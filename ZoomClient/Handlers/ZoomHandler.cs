using System;
using System.Collections.Generic;
using System.Text;

namespace AndcultureCode.ZoomClient.Handlers
{
    public static class ZoomHandler
    {
        private static ZoomClient Instance { get; set; }

        private static string UserId { get; set; }
        private static string Token { get; set; }
        private static string ZoomApiKey { get; set; }
        private static string ZoomApiSecret { get; set; }
        private static string ZoomApiBaseUrl { get; set; }

        private static string MeetingPassword { get; set; }

        public static void Initialize(string userId, string meetingPassword, string token, string zoomApiKey, string zoomApiSecret, string zoomApiBaseUrl)
        {
            UserId = userId;

            MeetingPassword = meetingPassword;

            Token = token;

            ZoomApiKey = zoomApiKey;

            ZoomApiSecret = zoomApiSecret;

            ZoomApiBaseUrl = zoomApiBaseUrl;

            Instance = new ZoomClient(new Models.ZoomClientOptions()
            {
                ZoomApiBaseUrl = ZoomApiBaseUrl,
                ZoomApiKey = ZoomApiKey,
                ZoomApiSecret = ZoomApiSecret
            });
        }

        public static ZoomClient GetZoomClient()
        {
            return Instance;
        }

        public static String GetUserId()
        {
            return UserId;
        }

        public static String GetToken()
        {
            return Token;
        }

        public static String GetMeetingPassword()
        {
            return MeetingPassword;
        }
    }
}
