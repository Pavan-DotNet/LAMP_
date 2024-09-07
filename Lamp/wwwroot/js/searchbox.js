
/*
-------------------------------------------
Function to Create Search Box Dynamically
-------------------------------------------
*/
function searchBox1Function() {
    var r = document.createElement('span');
    var y = document.createElement("INPUT");
    y.setAttribute("type", "text");
    y.setAttribute("placeholder", "Use + to lookup upto 3 Products Or Click Search for All");
    var g = document.createElement("IMG");
    g.setAttribute("src", "../images/delete.png");
    g.setAttribute("class", "deleteicon");
    y.setAttribute("onkeypress", "search(event)");
    y.setAttribute("Name", "searchfield_3");
    r.appendChild(y);
    g.setAttribute("onclick", "removeElement('myForm','id_1')");
    r.appendChild(g);
    r.setAttribute("id", "id_1");
    document.getElementById("myForm").appendChild(r);
    document.getElementById('but1').style.display = 'none';
}

function searchBox2Function() {
    var r = document.createElement('span');
    var y = document.createElement("INPUT");
    y.setAttribute("type", "text");
    y.setAttribute("placeholder", "Use + to lookup upto 3 Products Or Click Search for All");
    var g = document.createElement("IMG");
    g.setAttribute("src", "../images/delete.png");
    g.setAttribute("class", "deleteicon");
    y.setAttribute("onkeypress", "search(event)");
    y.setAttribute("Name", "searchfield_2");
    r.appendChild(y);
    g.setAttribute("onclick", "removeElement('myForm','id_2')");
    r.appendChild(g);
    r.setAttribute("id", "id_2");
    document.getElementById("myForm").appendChild(r);
    document.getElementById('but2').style.display = 'none';

}

/*
-----------------------------------------------
Function to Remove each Search Box Dynamically
-----------------------------------------------
*/
function removeElement(parentDiv, childDiv) {

    if (document.getElementById(childDiv)) {
        var child = document.getElementById(childDiv);
        var parent = document.getElementById(parentDiv);
        parent.removeChild(child);
    }
    else {
        return false;
    }
}

/*
----------------------------------------------------
Function to Remove Dynamically Added Search Boxes
----------------------------------------------------
*/
function resetElements() {
    document.getElementById('myForm').innerHTML = '';
    document.getElementById('but1').style.display = 'block';
    document.getElementById('but2').style.display = 'block';
    document.getElementById('mainform').reset();

}

/*
----------------------------------------------------
Function to get data when user hit enter
----------------------------------------------------
*/

function search(e) {
    if (e.keyCode == 13) {
        angular.element(document.getElementById('page-wrapper')).scope().search();
        return false; // returning false will prevent the event from bubbling up.
    }
}