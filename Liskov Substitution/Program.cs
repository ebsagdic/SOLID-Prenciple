
////Yanlış yaklaşım
//using Liskov_Substitution;

//AWS aws = new AWS();
//aws.MachineLearning();
//aws.Translate();

//Azure azure = new Azure();
//azure.MachineLearning();
//azure.Translate();

//Google google = new Google();
//google.MachineLearning();
//google.Translate();

////Doğru Yaklaşım

//using Liskov_Substitution;

//Cloudly cloudly = new AWSService();
//cloudly.MachineLearning();
//(cloudly as ITranslateable)?.Translate();

//cloudly = new AzureService();
//cloudly.MachineLearning();
//(cloudly as ITranslateable)?.Translate();

//cloudly = new GoogleService();
//cloudly.MachineLearning();
//(cloudly as ITranslateable)?.Translate();
