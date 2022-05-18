using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.Login
{
    [Serializable]
    public class LoginSession
    {
        public string StaffId { get; }
        private const string SessionFileName = "Login Session.ini";

        public LoginSession(string staffId)
        {
            StaffId = staffId;
        }
        
        public static void SaveSession(string staffId)
        {
            string directoryPath = UserSettingsDirectory.GetSettingsDirectory();
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            
            string sessionPath = Path.Combine(directoryPath, SessionFileName);

            if (File.Exists(sessionPath))
                File.Delete(sessionPath);
            var formatter = new BinaryFormatter();
            var stream = new FileStream(sessionPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, new LoginSession(staffId));
            stream.Dispose();
        }

        public static LoginSession GetSession()
        {
            string directoryPath = UserSettingsDirectory.GetSettingsDirectory();
            string sessionPath = Path.Combine(directoryPath, SessionFileName);


            if (!File.Exists(sessionPath))
            {
                throw new InvalidOperationException("No login session found.");
            }

            var stream = new FileStream(sessionPath, FileMode.Open, FileAccess.Read);
            var formatter = new BinaryFormatter();

            if (stream.Length == 0)
                throw new SerializationException("The file being deserialized is empty");
            var session = (LoginSession) formatter.Deserialize(stream);
            
            stream.Dispose();
            return session;
        }
    }
}