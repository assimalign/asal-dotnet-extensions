


namespace Assimalign.Extensions.DependencyInjection.MockObjects
{
    public class CreationCountFakeService
    {
        public static readonly object InstanceLock = new object();

        public CreationCountFakeService(IFakeService dependency)
        {
            InstanceCount++;
            InstanceId = InstanceCount;
        }

        public static int InstanceCount { get; set; }

        public int InstanceId { get; }
    }
}