using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoNorBeadando
{
    public class MainViewModel
    {
        public User user { get; set; }
        public MainViewModel()
        {
            var manager = new DataManager();
        }
    }
}
