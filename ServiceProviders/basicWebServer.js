var http = require('http');
const PORT = 3000;

var server = http.createServer(handleRequest);

function handleRequest(request, response) {
    console.log(getFormattedDate() + " - " + request.url + "");
}

server.listen(PORT, function(e) {
    console.log("Server listening on: http://localhost:%s", PORT);
});

function getFormattedDate() {
    var date = new Date();
    var str = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
    return str;
}
