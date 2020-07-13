using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    public class User
    {
        public string Email { get; set; }
        //public MyMenu MyMenu { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        //public int Age { get; set; }
        //public int Rating { get; set; }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>()
            {
                new User(){Email = "jaj", Name = "Daniel 'el covid nos va a matar' Salas", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Juank Galindo", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Aquiles doy", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Susana Oria", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Rosa Melano", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Daniel 'el covid nos va a matar' Salas", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Juank Galindo", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Aquiles doy", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Susana Oria", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Rosa Melano", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Daniel 'el covid nos va a matar' Salas", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Juank Galindo", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Aquiles doy", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Susana Oria", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Rosa Melano", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Daniel 'el covid nos va a matar' Salas", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Juank Galindo", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Aquiles doy", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Susana Oria", Password = "pepe"
                },
                new User(){Email = "jaj", Name = "Rosa Melano", Password = "pepe"
                }


            };
            return users;
        }
    }
}
