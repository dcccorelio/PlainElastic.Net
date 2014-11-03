﻿using Machine.Specifications;
using PlainElastic.Net.Utils;

namespace PlainElastic.Net.Tests.Integration.Connection
{
    [Subject(typeof(ElasticConnection))]
    class When_async_PUT_request_on_valid_ES_instance
    {
        Establish context = () =>
        {
            connection = new ElasticConnection("localhost", 9200);
        };


        Because of = () => 
            result = connection.Put(command: "/test/foo/1", 
                                         jsonData: "{ 'field': 'value' }".AltQuote()
                                         );

        It should_return_OK = () =>
            result.Result.ShouldContain("\"ok\":true");


        private static ElasticConnection connection;
        private static OperationResult result;
    }
}
