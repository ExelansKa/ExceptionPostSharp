using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNLogSample01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veri v = new Veri();
            //v.TransactionBaslat();
            //v.VeriGetir();
            //v.TransactionBitir();

            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {

                Logger logger = LogManager.GetLogger("databaseLogger");
                logger.ErrorException("asdasdasdasd", new NotImplementedException());

                logger.WarnException("warn exception", ex);
            }

            Console.ReadLine();
        }
    }

    class Veri
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public void TransactionBaslat()
        {
            logger.Info("Tran işlemi başlatıldı..");
        }

        public void VeriGetir()
        {
            logger.Error("hata Oldu.", new NotImplementedException());
        }

        public void TransactionBitir()
        {
            logger.Warn("Warn Hatası Oluştu");
        }

    }
}
