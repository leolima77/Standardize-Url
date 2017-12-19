using System;

public class StandardizeUrl
{
    public static string Converter(string entrada)
    {
        string palavraSemAcento = "indefinido";
        string caracterComAcento = "áàãâäéèêëíìîïóòõôöúùûüçÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÖÔÚÙÛÜÇ,. ?&:/!;ºª%‘’()\"”“#+";
        string caracterSemAcento = "aaaaaeeeeiiiiooooouuuucAAAAAEEEEIIIIOOOOOUUUUC----------------------";

        if (String.IsNullOrEmpty(entrada))
            return palavraSemAcento;

        for (int i = 0; i < entrada.Length; i++)
        {
            if (caracterComAcento.IndexOf(Convert.ToChar(entrada.Substring(i, 1))) >= 0)
            {
                int car = caracterComAcento.IndexOf(Convert.ToChar(entrada.Substring(i, 1)));
                palavraSemAcento += caracterSemAcento.Substring(car, 1);
            }
            else
                palavraSemAcento += entrada.Substring(i, 1);
        }

        string[] cEspeciais = { "#39", "---", "--", "'", "\r\n", "\n", "\r", "#8220", "#8221", "#", "<i>", "<-i>", "<br>", "<br />" };

        for (int q = 0; q < cEspeciais.Length; q++)
            palavraSemAcento = palavraSemAcento.Replace(cEspeciais[q], "-");

        for (int x = (cEspeciais.Length - 1); x > -1; x--)
            palavraSemAcento = palavraSemAcento.Replace(cEspeciais[x], "-");

        palavraSemAcento = palavraSemAcento.ToLower().Replace(Environment.NewLine, "").TrimStart('-').TrimEnd('-')
                                                     .Replace("--", "-");

        return palavraSemAcento.ToLower();
    }
}
