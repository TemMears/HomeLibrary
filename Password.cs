using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace п2
{
    class Password
    {
        public string GetHash(string input)
        {
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        WorkingFiles savingPass = new WorkingFiles();
        public bool CheckPass(string password)
        {
            string passwordHash = GetHash(password);
            string svPassword = savingPass.PassFromFiles();
            return (svPassword == passwordHash);
        }
        public void NewPass(string newPass)
        {
            var hash = GetHash(newPass);
            savingPass.PassToFile(hash);
        }
        public bool Reset(string input)
        {
            string standart = "nevvZqM+JdenLq9X7t+lddi91CP51g96eEW3KSdtg7Y=";
            if (GetHash(input) == standart)
            {
                savingPass.PassToFile(standart);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
