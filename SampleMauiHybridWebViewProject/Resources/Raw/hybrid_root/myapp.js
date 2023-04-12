function SendMessageToCSharp() {
    var message = document.getElementById('messageInput').value;
    HybridWebView.SendRawMessageToDotNet(message);
}
