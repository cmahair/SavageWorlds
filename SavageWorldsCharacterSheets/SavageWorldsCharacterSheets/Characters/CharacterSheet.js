
function load_clicked() {
    
}

function OnLoadSuccess(response) {
    
}

function OnLoadFail(error) {
    
}

function new_clicked() {
    // TODO don't do server, just do client, silly.
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

function validateNumeric(element) {
    if (isNaN(element.Text)) {
        element.Text = "";
    }
}