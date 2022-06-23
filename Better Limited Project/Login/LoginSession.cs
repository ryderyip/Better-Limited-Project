using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Better_Limited_Project.SettingsUtility;
using Better_Limited_Project.StaffUtility.StaffEntity;

namespace Better_Limited_Project.Login
{
    [Serializable]
    public class LoginSession
    {
        private const string SessionFileName = "Login Session.ini";

        public LoginSession(Staff currentStaff)
        {
            CurrentStaff = currentStaff;
        }

        public Staff CurrentStaff { get; }

        public static void SaveSession(Staff staff)
        {
            string directoryPath = UserSettingsDirectory.GetSettingsDirectory();
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string sessionPath = Path.Combine(directoryPath, SessionFileName);

            if (File.Exists(sessionPath))
                File.Delete(sessionPath);
            var formatter = new BinaryFormatter();
            var stream = new FileStream(sessionPath, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, new LoginSession(staff));
            stream.Dispose();
        }

        public static LoginSession GetSession()
        {
            string directoryPath = UserSettingsDirectory.GetSettingsDirectory();
            string sessionPath = Path.Combine(directoryPath, SessionFileName);


            if (!File.Exists(sessionPath)) throw new InvalidOperationException("No login session found.");

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