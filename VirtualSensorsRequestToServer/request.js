var request = require('request');
var rn = require('random-number');
var moment = require('moment');

var pulsesGen = rn.generator({
  min:  0, 
  max:  1000, 
  integer: true
});

var sensorIdGen = rn.generator({
  min:  1, 
  max:  4, 
  integer: true
});

var formData = {
 	Id:0,
 	NumberOfNP: pulsesGen(),
 	SensorId:sensorIdGen(),
 	SensorDate: moment().toISOString(),
 	Meter2Value: 0,
 	Meter3Value: 0,
 	NumberOfPP:0,
 	Meter1Value: 0
};

request.post(
	{
		url:'http://localhost:8110/api/Values', 
		form: formData
	}, 
	function optionalCallback(err, httpResponse, body) {
  		if (err) {
    		return console.error('Failed:', err);
  		}
  		console.log('Successful!  Server responded with:', body);
	}
);