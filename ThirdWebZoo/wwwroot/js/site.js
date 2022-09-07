msg = "Your Comment Accepted"

deleteMsg = "Your Delete succeeded"

editMsg = "You Edit it Correctly"

function ValidateSubmit() {
    let test = document.getElementsByName("UserName");
    let test2 = document.getElementsByName("Password");
    if (test == null && test2 == null)
        alert("Invalid input");
    return "Correct";
};

function onSignIn(googleUser) {
    var profile = googleUser.getBasicProfile();
    console.log('ID: ' + profile.getId()); // Do not send to your backend! Use an ID token instead.
    console.log('Name: ' + profile.getName());
    console.log('Image URL: ' + profile.getImageUrl());
    console.log('Email: ' + profile.getEmail()); // This is null if the 'email' scope is not present.
}

