using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace CRUD_Api.providers
{
    public sealed class NewtonsoftJsonValidationMetadataProvider :
        Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IDisplayMetadataProvider,
        Microsoft.AspNetCore.Mvc.ModelBinding.Metadata.IValidationMetadataProvider
    {
        public void CreateDisplayMetadata(DisplayMetadataProviderContext context)
        {
            throw new NotImplementedException();
        }

        public void CreateValidationMetadata(ValidationMetadataProviderContext context)
        {
            throw new NotImplementedException();
        }
    }
}
