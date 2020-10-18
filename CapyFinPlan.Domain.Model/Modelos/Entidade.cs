using Flunt.Notifications;

using System;

namespace CapyFinPlan.Domain.Model.Modelos
{
    public class Entidade : Notifiable
    {
        public Entidade() => Id = Guid.NewGuid();

        public Entidade(Guid idGuid)
        {
            if (idGuid != Guid.Empty)
            {
                Id = idGuid;
            }
        }

        public Guid Id { get; private set; }
    }
}