﻿namespace testfsharp

open System
open Xamarin.Forms
//open Amazon;
//open Amazon.DynamoDBv2
//open Amazon.Runtime
//open Amazon.DynamoDBv2.Model
//open System.Collections.Generic


open FSharp.AWS.DynamoDB

type WorkItemInfo =
                    {
                        [<HashKey>]
                        ProcessId : int64
                        [<RangeKey>]
                        WorkItemId : int64
        
                        Name : string
                        UUID : Guid
                        Dependencies : Set<string>
                        Started : DateTimeOffset option
                    }

type blankcsharpPage() = 
    inherit ContentPage()
    do 
        //let client = new AmazonDynamoDBClient(new SessionAWSCredentials("ASIAIJQISLMOY7RK3OQA", "YYZWCd+SxsYv9HAFpQRLkMrfX7QeEaWi6B0/b1//", "FQoDYXdzEFcaDDdbVZer1w2Az2NAuSLHAaPTkTiISHfdNOf0upnChcfzpdfmFiG12kSjjwhl7TOefErCy63shq30Bl/rbhlqdunjFC9kiLOEp2w3GnPVcV8vfSZ13xDWX6KBbiAD2MAgMoPV+ajN9W2IW4hnXxepCqR7QL0M0a8qdv65pZDXglajbJ8Q7B2fPHv9d7zNhxgSXiX24TZwhATwxpFD9JRld3S+dau7+raJvymoN/r9vQY1YR7TvDhvJf406yRjkSNDVhdf42wSCjiM0NwM+t1SUFP08oGOinUo9JnMvAU="))

        //let request = new BatchGetItemRequest()

        //let attributeValue1 = new AttributeValue()
        //attributeValue1.S <- "235c386c-d0bb-4718-bb27-ac182591fcc3"

        //let attributeValue2 = new AttributeValue()
        //attributeValue2.S <- "376ca1b5-ca67-4748-9776-d5e1d55213e7"

        //let attributeValues = new Dictionary<string, AttributeValue>()
        //attributeValues.Add("FeedItemId", attributeValue1)

        //let attributeValues = new Dictionary<string, AttributeValue>()
        //attributeValues.Add("FeedItemId", attributeValue2)

        //let keys = new List<Dictionary<string, AttributeValue>>()
        //keys.Add(attributeValues)

        //let keysAndAttributes = new KeysAndAttributes()
        //keysAndAttributes.Keys <- keys

        //request.RequestItems <- new Dictionary<string, KeysAndAttributes> ()
        //request.RequestItems.Add("FeedItem", keysAndAttributes)

        //let items = client.BatchGetItemAsync(request)
 

        
                

        let layout = StackLayout() 

        layout.Children.Add(Label(Text = "Hello ContentPage"))
        base.Content <- layout