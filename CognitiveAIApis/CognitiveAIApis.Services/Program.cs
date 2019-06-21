﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Rest;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using CognitiveAIApis.Services;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using CognitiveAIApis.Infrastructure;
using static CognitiveAIApis.Services.CustomVisionApis;
using CognitiveAIApis.Models.CustomVision;
using CognitiveAIApis.Services.Models;

namespace CognitiveAIApis.Services
{
    class Program
    {
        private const string subscriptionKey = "8cf15696a50e46d6b5c8b8d14fabeec6";

        private const string faceEndpoint =
            "https://westus.api.cognitive.microsoft.com";

        private const string localImagePath = @"Images/image.jpg";

        private const string remoteImageUrl =
            "http://images5.fanpop.com/image/photos/26900000/Nicolas-Cage-nicolas-cage-26969804-2069-2560.jpg";

        static void Main(string[] args)
        {
            var credential = new ApiCredential { Endpoint = faceEndpoint, Version = "v1.0", SubscriptionKey = subscriptionKey };
            var faceApis = new FaceApis(credential);
            faceApis.DetectFacesAsync(new { imageFilePath = localImagePath }).Wait();
            var result = CreateProjectAsync(new { name = "testProject"}).Result;
            dynamic tagResult0 = CreateTagAsync(new { projectId = result.id, tagName = "fork" }).Result;
            dynamic tagResult1 = CreateTagAsync(new { projectId = result.id, tagName = "scissor" }).Result;
            var requestObject = new CreateImagesRequest()
            {
                images = new List<ImageUrl>
                {
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_1.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_2.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_3.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_4.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_5.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_6.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_7.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_8.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_9.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_10.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/fork/fork_11.jpg?raw=true",
                        tagIds = new List<string>{ tagResult0.id }
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_1.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_2.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_3.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_4.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_5.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_6.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_7.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_8.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_9.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_10.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    },
                    new ImageUrl
                    {
                        url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_11.jpg?raw=true",
                        tagIds = new List<string>{ tagResult1.id}
                    }
                }
            };
            var createImagesResult = CreateImagesFromUrlsAsync(new { projectId = result.id, images = requestObject.images }).Result;
            var trainingResult = TrainProjectAsync(new { projectId = result.id }).Result;
            var iterations = GetIterations(new { projectId = result.id }).Result;
            var updateIterationResult = UpdateIteration(new { projectId = result.id, iterationId = iterations[0].id, iteration = new { isDefault=true } }).Result;
            var quicktest = QuickTestImageWithUrlAsync(iterations[0].id, result.id, new { url = "https://github.com/Azure/LearnAI-Bootcamp/blob/master/lab01.3_customvision02/Resources/Starter/CustomVision.Sample/Images/scissors/scissors_15.jpg?raw=true" }).Result;
        }

        static async Task WaitCallLimitPerSecondAsync()
        {
            const int callLimitPerSecond = 10;
            Queue<DateTime> _timeStampQueue = new Queue<DateTime>(callLimitPerSecond);
            Monitor.Enter(_timeStampQueue);
            try
            {
                if (_timeStampQueue.Count >= callLimitPerSecond)
                {
                    TimeSpan interval = DateTime.UtcNow - _timeStampQueue.Peek();
                    if (interval < TimeSpan.FromSeconds(1))
                    {
                        await Task.Delay(TimeSpan.FromSeconds(1) - interval);
                    }
                    _timeStampQueue.Dequeue();
                }
                _timeStampQueue.Enqueue(DateTime.UtcNow);
            }
            finally
            {
                Monitor.Exit(_timeStampQueue);
            }
        }        
    }
}
