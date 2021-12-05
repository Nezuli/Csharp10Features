namespace CSharp10Features.ConstantInterpolatedStrings
{
    internal class ApiRoutes
    {
        private const string ApiBase = "/api";

        public static class Library
        {
            private const string Base = ApiBase + "/library";
            public const string GetAll = Base;
            //public const string GetById = Base + "/{id:guid}";
            //public const string GetById = $"{Base}/{{id:guid}}"; // New way
            public static readonly string GetById = $"{Base}/{{id:guid}}"; // Old way
            public static readonly string Add = $"{Base}/{{id:guid}}";
        }
    }
}
