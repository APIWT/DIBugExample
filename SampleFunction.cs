namespace DIBugExample
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Extensions.Logging;

    public class SampleFunction
    {
        private readonly IGreeter greeter;

        public SampleFunction(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        [FunctionName("SampleFunction")]
        public void Run(
            [QueueTrigger("my-queue")]
            string myQueueItem,
            ILogger logger)
        {
            logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            logger.LogInformation(this.greeter.GetGreeting("Anthony"));
        }

    }
}
