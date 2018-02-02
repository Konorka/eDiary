using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoNorBeadando
{
    public class LoginViewModel
    {
        public int UserId { get; set; }
        public int UserAcces { get; set; }
        public eDiaryModelDB context = new eDiaryModelDB();

        public int Login(string username, string password)
        {
            var user = context.User.FirstOrDefault(x => x.username == username);
            
            if (user != null)
            {
                if (user.password == password)
                {
                    UserId = user.user_id;
                    return user.user_access_rank;
                }
            } return -1;
        }
              

    }
}


