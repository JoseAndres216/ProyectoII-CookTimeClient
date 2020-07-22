using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    public class Enterprise
    {
        public string Email { get; set; }
        //public MyMenu MyMenu { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        //public string Contactinfo { get; set; }
        //public int Rating { get; set; }

        public List<Enterprise> GetEnterprises()
        {
            List<Enterprise> enterprises = new List<Enterprise>() 
            { 
                new Enterprise(){Email = "jaj", Name = "Venta organos pepe", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Bar Citras", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Restaurante el pedo", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Asetec", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Libreria estudiante morido", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Venta organos pepe", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Bar Citras", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Restaurante el pedo", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Asetec", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Libreria estudiante morido", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Venta organos pepe", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Bar Citras", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Restaurante el pedo", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Asetec", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Libreria estudiante morido", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Venta organos pepe", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Bar Citras", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Restaurante el pedo", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Asetec", Password = "pepe"
                },
                new Enterprise(){Email = "jaj", Name = "Libreria estudiante morido", Password = "pepe"
                }
            };
            return enterprises;
        }
    }
}
