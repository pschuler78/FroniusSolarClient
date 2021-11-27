using FroniusSolarClient.Entities.SolarAPI.V1;
using FroniusSolarClient.Entities.SolarAPI.V1.MeterRealtimeData;
using System.Collections.Generic;

namespace FroniusSolarClient.Services
{
    /// <summary>
    /// These requests will be provided where direct access to the realtime data of the devices is possible. This is currently the case for the Fronius Datalogger Web and the Fronius Datamanager.
    /// </summary>
    internal class MeterRealtimeDataService : BaseDataService
    {
        private readonly string _cgi = "GetMeterRealtimeData.cgi";

        public MeterRealtimeDataService(RestClient restClient) 
            : base(restClient)
        {
        }


        /// <summary>
        /// Builds the query string for the request
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        protected string BuildQueryString(int deviceId, Scope scope)
        {
            //TODO: Support list of string dictionary to build HTTP query string
            return $"?Scope={scope}&DeviceId={deviceId}";
        }

        public Response<Dictionary<int, MeterRealtimeData>> GetSystemMeterData()
        {
            string baseEndpointURL = _cgi + $"?Scope=System";           
            return GetDataServiceResponse<Dictionary<int, MeterRealtimeData>>(baseEndpointURL);
        }

        public Response<MeterRealtimeData> GetDeviceMeterData(int deviceId = 0)
        {
            string baseEndpointURL = _cgi + $"?Scope=Device&DeviceId={deviceId}";
            return GetDataServiceResponse<MeterRealtimeData>(baseEndpointURL); 
        }
    }
}
