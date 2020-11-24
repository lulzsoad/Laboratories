console.log("before function");
(function () {
    console.log("function started");
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];

    console.log("before AddNewItem function");
    const addNewItem = async () => {

        const requestData = formElement;

        const response = await fetch("api/[]", {
            method: "POST",
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify(requestData)
        })

        const responseJson = await response.json();
        if (responseJson.success) {
            console.log("success")
            alertElement.style.display = block;
        }
    };

    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();

            addNewItem().then(() => console.log("added successfully"));
        })
    })
})();
