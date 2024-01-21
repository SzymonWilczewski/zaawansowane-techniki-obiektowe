using RefactorExample.Statements;

namespace RefactorExample.Render
{
    internal interface IRenderer
    {
        string Render(StatementData data);
    }
}
