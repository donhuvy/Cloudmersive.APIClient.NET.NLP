/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.NLP.Client;
using Cloudmersive.APIClient.NET.NLP.Api;
using Cloudmersive.APIClient.NET.NLP.Model;

namespace Cloudmersive.APIClient.NET.NLP.Test
{
    /// <summary>
    ///  Class for testing PosTaggerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PosTaggerApiTests
    {
        private PosTaggerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PosTaggerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PosTaggerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PosTaggerApi
            //Assert.IsInstanceOfType(typeof(PosTaggerApi), instance, "instance is a PosTaggerApi");
        }

        
        /// <summary>
        /// Test PosTaggerTagAdjectives
        /// </summary>
        [Test]
        public void PosTaggerTagAdjectivesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagAdjectives(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
        /// <summary>
        /// Test PosTaggerTagAdverbs
        /// </summary>
        [Test]
        public void PosTaggerTagAdverbsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagAdverbs(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
        /// <summary>
        /// Test PosTaggerTagNouns
        /// </summary>
        [Test]
        public void PosTaggerTagNounsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagNouns(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
        /// <summary>
        /// Test PosTaggerTagPronouns
        /// </summary>
        [Test]
        public void PosTaggerTagPronounsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagPronouns(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
        /// <summary>
        /// Test PosTaggerTagSentence
        /// </summary>
        [Test]
        public void PosTaggerTagSentenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagSentence(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
        /// <summary>
        /// Test PosTaggerTagVerbs
        /// </summary>
        [Test]
        public void PosTaggerTagVerbsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PosRequest request = null;
            //var response = instance.PosTaggerTagVerbs(request);
            //Assert.IsInstanceOf<PosResponse> (response, "response is PosResponse");
        }
        
    }

}