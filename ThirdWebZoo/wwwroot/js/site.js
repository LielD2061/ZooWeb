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
