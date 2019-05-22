$(() => {
    $("#submit").on('click', () => {
        const urlOrigin = $("#url-origin").val();

        $.post('/home/ShortenURL', { URLOriginal: urlOrigin }, function (URLShortened) {
            $("#url-result").val(URLShortened);
        });
    });
});