var attempt = 3; //Here I declare this Variable to count number of attempts

//This function Executes on click of login button
function validate(){
	var username = document.getElementById("username").value;
	var password = document.getElementById("password").value;

	if ( username == "CPUH" && password == "cpuh@123"){
		alert ("Login successfully");
		window.location = "success.html";
		return false;
	}
	else{
		attempt --;//Decrementing by one -->  There are max 3 attempts
		alert("Incorrect Password !! You have left "+attempt+" attempt;");
		
		//Disabling fields after 3 attempts
		if( attempt == 0){
			document.getElementById("username").disabled = true;
			document.getElementById("password").disabled = true;
			document.getElementById("submit").disabled = true;
			return false;
		}
	}
}