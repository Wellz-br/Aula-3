using System;

public class Program
{
    public static void Main(string[] args)
    {
        Televisao minhaTv = new Televisao();

        Console.WriteLine("Canal inicial: " + minhaTv.ObterCanalAtual());
        Console.WriteLine("Volume inicial: " + minhaTv.ObterVolumeAtual());

        minhaTv.MudarParaCanal(10);
        Console.WriteLine("Canal após mudar para 10: " + minhaTv.ObterCanalAtual());

        minhaTv.SubirCanal();
        Console.WriteLine("Canal após subir: " + minhaTv.ObterCanalAtual());

        minhaTv.AumentarVolume();
        minhaTv.AumentarVolume();
        Console.WriteLine("Volume após aumentar 2 vezes: " + minhaTv.ObterVolumeAtual());

        minhaTv.AlternarMudo();
        Console.WriteLine("Mudo ativado? " + minhaTv.EstaMudo());
        Console.WriteLine("Volume após mudo: " + minhaTv.ObterVolumeAtual());

        minhaTv.AlternarMudo();
        Console.WriteLine("Mudo ativado? " + minhaTv.EstaMudo());
        Console.WriteLine("Volume após desativar mudo: " + minhaTv.ObterVolumeAtual());
    }
}

