using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Oop3
{
    public class BasvuruManager
    {
        //çok önemli -> dependency injection
        //method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //değerlendirme kodları

            //böyle yazarsak hepsi tek türe bağımlı olur ondansa paramatre olarak interfaceyi gönder
            //metot çağrılırken seçsin kredi türünü
            //KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            //doğrusu
            krediManager.Hesapla();
            loggerService.Log();

        }

        //kredi başvurusunda birden fazla loglama sağladık
        public void BasvuruYap2(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //değerlendirme kodları

            //böyle yazarsak hepsi tek türe bağımlı olur ondansa paramatre olarak interfaceyi gönder
            //metot çağrılırken seçsin kredi türünü
            //KonutKrediManager konutKrediManager1 = new KonutKrediManager();
            //konutKrediManager1.Hesapla();

            //doğrusu
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
        }


        //bir hesaplamayı birden fazla yere loglama
        public void KrediOnBilgilendirmesiYap2(List<IKrediManager> krediManagers,List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();

                foreach (var logger in loggerServices)
                {
                    logger.Log();
                }
            }
        }

    }

}
