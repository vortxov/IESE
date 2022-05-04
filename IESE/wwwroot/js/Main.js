async function CheckAuthorize() {//ПРОВЕРКА НА АВТОРИЗАЦИЮ(ЕСТЬ НЕТ)
    const response = await fetch("/account/Authorize", {
        method: "GET",
        headers: { "Accept": "application/json" },
    });
    if (response.ok === false) {
        window.location.href = '/Page/Account.html';
    }
}



async function CheckAuthorizeRole() {//ЯВЛЯЕТСЯ ЛИ АВТОРИЗИРОВАВШИЙСЯ АДМИНОМ
    const response = await fetch("/account/AuthorizeRole", {
        method: "GET",
        headers: { "Accept": "application/json" },
    });
    if (response.ok === true) {
       return await response.json();
    }
}