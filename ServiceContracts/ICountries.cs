using ServiceContracts.DTOs.CountryDTO;

namespace ServiceContracts
{
    public interface ICountries
    {
        Task< CountryResponse> AddCountry(CountryAddRequest? request);

       Task<  List <CountryResponse>> GetAllCountries();

        Task< CountryResponse>? GetCountryById(Guid? id);

    }
}
