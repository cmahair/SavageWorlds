
function load_clicked() {
    this.alert("clicked");
    PageMethods.BuildCharacter("Bob",OnSuccess,OnFail);
}

function OnSuccess(response) {
    this.alert(response);
}

function OnFail(error) {
    this.alert(error);
}

