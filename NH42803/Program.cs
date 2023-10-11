using NHibernate.Cfg;
using NHibernate.Linq;
using NH42803;

var factory = new Configuration()
    .Configure()
    .AddAssembly(typeof(Update).Assembly)
    .BuildSessionFactory();

using var s = factory.OpenSession();

var newestTargetEntries = s.Query<Entry>()
    .Fetch(x => x.Update)
    .GroupBy(x => x.Target)
    .Select(x => x.OrderByDescending(y => y.Update.Date).First())
    .ToList();

;
