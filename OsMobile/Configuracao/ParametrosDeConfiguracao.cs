using System;
namespace OsMobile.Configuracao
{
    public static class ParametrosDeConfiguracao
    {
        public static string host { get; } = "www.inventi9.srv.br";

        public static int port { get; } = 555;

        public static string BaseUrl { get; set; }

        public static string BaseUrlInstituicao { get; } = string.Format("http://{0}", host); //"http://DESKTOP-R2UCFP4"; //

        public static int TempoConexao { get; } = 500;
    }
}
