
function load_clicked() {
    PageMethods.BuildCharacter("Bob",OnLoadSuccess,OnLoadFail);
}

function OnLoadSuccess(response) {
    this.alert(response);
}

function OnLoadFail(error) {
    this.alert(error);
}

function new_clicked() {
    PageMethods.NewCharacter(OnNewSuccess, OnNewFail);
}

function OnNewSuccess(response) {
    document.getElementById("content_tbname").value = response.Name;
}

function OnNewFail(error) {

}

function save_clicked() {

}

function OnSaveSuccess(response) {

}

function OnSaveFail(error) {

}