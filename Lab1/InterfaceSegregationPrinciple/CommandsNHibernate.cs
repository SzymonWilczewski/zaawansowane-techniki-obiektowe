using NHibernate;

namespace InterfaceSegregationPrinciple
{
    public class CommandsNHibernate : ICommands
    {
        private readonly ISession session;

        public CommandsNHibernate(ISession session)
        {
            this.session = session;
        }

        public void Save(Entity entity)
        {
            using (var transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
        }

        public void Delete(Entity entity)
        {
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(entity);
                transaction.Commit();
            }
        }
    }
}
