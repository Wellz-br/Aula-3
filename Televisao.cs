public class Televisao
{
    private const int CANAL_MAXIMO = 520;
    private const int VOLUME_MINIMO = 0;
    private const int VOLUME_MAXIMO = 100;

    private int canalAtual;
    private int ultimoCanalAssistido;
    private int volumeAtual;
    private int volumeAntesDoMudo;
    private bool mudoAtivado;

    public Televisao()
    {
        // Ao ligar, o canal deve ser o último assistido. Inicializamos como canal 1, por exemplo.
        canalAtual = 1;
        ultimoCanalAssistido = 1;
        volumeAtual = 50; // volume inicial padrão
        volumeAntesDoMudo = volumeAtual;
        mudoAtivado = false;
    }

    // Método para validar se o canal é válido
    private bool CanalValido(int canal)
    {
        return canal >= 0 && canal <= CANAL_MAXIMO;
    }

    // Método para ligar a TV no último canal assistido
    public void Ligar()
    {
        canalAtual = ultimoCanalAssistido;
    }

    // Método para mudar direto para um canal informado
    public void MudarParaCanal(int canal)
    {
        if (CanalValido(canal))
        {
            canalAtual = canal;
            ultimoCanalAssistido = canal;
        }
        else
        {
            // Pode lançar exceção ou ignorar mudança
        }
    }

    // Método para aumentar o canal em 1
    public void SubirCanal()
    {
        if (canalAtual < CANAL_MAXIMO)
        {
            canalAtual++;
            ultimoCanalAssistido = canalAtual;
        }
    }

    // Método para diminuir o canal em 1
    public void DescerCanal()
    {
        if (canalAtual > 0)
        {
            canalAtual--;
            ultimoCanalAssistido = canalAtual;
        }
    }

    // Método para aumentar volume em 1
    public void AumentarVolume()
    {
        if (!mudoAtivado && volumeAtual < VOLUME_MAXIMO)
        {
            volumeAtual++;
            volumeAntesDoMudo = volumeAtual;
        }
    }

    // Método para diminuir volume em 1
    public void DiminuirVolume()
    {
        if (!mudoAtivado && volumeAtual > VOLUME_MINIMO)
        {
            volumeAtual--;
            volumeAntesDoMudo = volumeAtual;
        }
    }

    // Método para ativar ou desativar o mudo
    public void AlternarMudo()
    {
        if (!mudoAtivado)
        {
            volumeAntesDoMudo = volumeAtual;
            volumeAtual = 0;
            mudoAtivado = true;
        }
        else
        {
            volumeAtual = volumeAntesDoMudo;
            mudoAtivado = false;
        }
    }

    // Métodos para obter o estado atual da TV, úteis para testes
    public int ObterCanalAtual()
    {
        return canalAtual;
    }

    public int ObterVolumeAtual()
    {
        return volumeAtual;
    }

    public bool EstaMudo()
    {
        return mudoAtivado;
    }
}

