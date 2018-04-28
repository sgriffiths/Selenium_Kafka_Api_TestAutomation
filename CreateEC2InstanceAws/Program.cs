using System;
using Amazon.S3;

// Add using statements to access AWS SDK for .NET services. 
// Both the Service and its Model namespace need to be added 
// in order to gain access to a service. For example, to access
// the EC2 service, add:
// using Amazon.EC2;
// using Amazon.EC2.Model;

namespace CreateEC2InstanceAws
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IAmazonS3 s3Client = new AmazonS3Client();

            Console.Read();
        }
    }
}