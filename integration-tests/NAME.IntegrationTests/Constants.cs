using System;

public static class Constants {
    public static string ExpectedOperatingSystem;

    // Latest versions
    public static string LatestMongoHostname;
    public static string LatestRabbitHostname;
    public static string LatestSqlServerHostname;

    // Specific versions
    public static string SpecificMongoHostname;
    public static string SpecificRabbitHostname;
    public static string SpecificServiceHostname;

    public static string SpecificMongoVersion;
    public static string SpecificRabbitVersion;
    public static string SpecificServiceVersion;

    // Elasticsearch variables
    public static string LatestElasticHostname;
    public static string SpecificElasticHostname;
    public static string SpecificElasticVersion;

    static Constants() {
        ExpectedOperatingSystem = Environment.GetEnvironmentVariable("OPERATING_SYSTEM") ?? "windows";

        LatestMongoHostname = Environment.GetEnvironmentVariable("LATEST_MONGO_HOSTNAME") ?? "localhost";
        LatestRabbitHostname = Environment.GetEnvironmentVariable("LATEST_RABBIT_HOSTNAME") ?? "localhost";
        LatestSqlServerHostname = Environment.GetEnvironmentVariable("LATEST_SQLSERVER_HOSTNAME") ?? "localhost";

        SpecificMongoHostname = Environment.GetEnvironmentVariable("SPECIFIC_MONGO_HOSTNAME") ?? "localhost";
        SpecificRabbitHostname = Environment.GetEnvironmentVariable("SPECIFIC_RABBIT_HOSTNAME") ?? "localhost";
        SpecificServiceHostname = Environment.GetEnvironmentVariable("SPECIFIC_SERVICE_HOSTNAME") ?? "dummy-service";

        SpecificMongoVersion = Environment.GetEnvironmentVariable("SPECIFIC_MONGO_VERSION") ?? "3.0.0";
        SpecificRabbitVersion = Environment.GetEnvironmentVariable("SPECIFIC_RABBIT_VERSION") ?? "3.6.5";
        SpecificServiceVersion = Environment.GetEnvironmentVariable("SPECIFIC_SERVICE_VERSION") ?? "1.0.0";

        LatestElasticHostname = Environment.GetEnvironmentVariable("LATEST_ELASTIC_HOSTNAME") ?? "localhost";
        SpecificElasticHostname = Environment.GetEnvironmentVariable("SPECIFIC_ELASTIC_HOSTNAME") ?? "localhost";
        SpecificElasticVersion = Environment.GetEnvironmentVariable("SPECIFIC_ELASTIC_VERSION") ?? "5.5.1";
    }
}