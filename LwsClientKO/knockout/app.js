function initMap() {
        var myLatLng = {lat: -34.397, lng: 150.644};
        // Create a map object and specify the DOM element for display.
        var map = new google.maps.Map(document.getElementById('map'), {
          center: myLatLng,
          scrollwheel: false,
          zoom: 15
        });

        // Create a marker and set its position.
        var marker = new google.maps.Marker({
          map: map,
          position: myLatLng,
          title: 'Hello World!'
        });

    }

function SensorInformation(sensorData){
	var self = this;
	
	self.sensorData = ko.observable(sensorData);
	self.position = ko.observable('');
	self.fullName = ko.computed(function(){
		return self.sensorData().user.userProfile.firstName +' '+ self.sensorData().user.userProfile.lastName;
	},self);
	ko.computed(function(){
		self.geocoder = new google.maps.Geocoder;
	    var latlng = {lat: parseFloat(self.sensorData().latitude), lng: parseFloat(self.sensorData().longitude)};
	    self.geocoder.geocode({'location': latlng}, function(results, status) {
		    if (status === google.maps.GeocoderStatus.OK) {
		    	if (results[0]) {
		      		console.log(results[0].formatted_address);
		      		self.position(results[0].formatted_address);
		    	} 
		    	else {
		        	window.alert('No results found');
		      	}
		    } 	
		    else {
		    	window.alert('Geocoder failed due to: ' + status);
		    }			    
			});
		}, self);
	self.toLocation = function() {
        var myLatLng = {lat: parseFloat(self.sensorData().latitude), lng: parseFloat(self.sensorData().longitude)};
        // Create a map object and specify the DOM element for display.
        var map = new google.maps.Map(document.getElementById('map'), {
          center: myLatLng,
          scrollwheel: false,
          zoom: 15
        });

        // Create a marker and set its position.
        var marker = new google.maps.Marker({
          map: map,
          position: myLatLng,
          title: 'Hello World!'
        });

    }
}
function SensorViewModel() {
	var self = this;

    self.aviableSensors = [{ 
    		ssn:"0000001-AAA", 
    		name:"X-1.0.0", 
    		user: { 
    			userProfile: { 
    				firstName:"Igor", 
    				lastName:"Postinyk", 
    				city:null 
    			}
    		},
    		latitude:"49.997167",
    		longitude:"36.251793"
    	},
    	{
    		ssn: "0000002-BBB", 
    		name: "X-1.0.0", 
    		user: { 
    			userProfile: { 
    				firstName: "Vladymir", 
    				lastName:  "Knyazev", 
    				city: null 
    			}
    		},
    		latitude: "50.010310",
    		longitude: "36.228983"
    	},
    	{
    		ssn: "0000003-CCC", 
    		name: "X-1.0.0", 
    		user: { 
    			userProfile: { 
    				firstName: "Stats", 
    				lastName:  "Shalamov", 
    				city: null 
    			}
    		},
    		latitude: "50.034932",
    		longitude: "36.219906"
    	},
    	{
    		ssn: "0000004-DDD", 
    		name: "X-1.0.0", 
    		user: { 
    			userProfile: { 
    				firstName: "Vladymir", 
    				lastName:  "Knyazev", 
    				city: null 
    			}
    		},
    		latitude: "50.027820",
    		longitude: "36.317485"
    	}];
    self.sensors = ko.observableArray([
    		new SensorInformation(self.aviableSensors[0]),
    		new SensorInformation(self.aviableSensors[1]),
    		new SensorInformation(self.aviableSensors[2]),
    		new SensorInformation(self.aviableSensors[3])
    	]);
}
// Activates knockout.js
ko.applyBindings(new SensorViewModel());