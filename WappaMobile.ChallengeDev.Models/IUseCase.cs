namespace WappaMobile.ChallengeDev.Models
{
    /// <summary>
    /// Um caso de uso que define uma meta/objetivo do usuário dentro do sistema. Ele é descrito por um fluxo principal e fluxos alternativos e sua execução depende de input e output denominados Pré-Condições e Pós-Condições.
    /// </summary>
    /// <typeparam name="Input">Pré-condições: Informações que são premissas para que o caso de uso seja executado.</typeparam>
    /// <typeparam name="Output">Pós-condições: Informações geradas sobre o que foi alterado depois da execução de modo que seja mensurável seu sucesso.</typeparam>
    public interface IUseCase<Input, Output> where Input : IPreCondition where Output : IPostCondition
    {
        /// <summary>
        /// Inicia a execução dos fluxos básicos e alternativos do sistema.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Output Execute(Input request);
    }
}
