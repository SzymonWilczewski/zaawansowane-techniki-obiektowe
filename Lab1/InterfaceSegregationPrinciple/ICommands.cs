namespace InterfaceSegregationPrinciple
{
    public interface ICommands
    {
        void Save(Entity entity);
        void Delete(Entity entity);
    }
}
