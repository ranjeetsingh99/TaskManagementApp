
/*Sidebar collapsing js................................................ */

document.addEventListener('DOMContentLoaded', function () {
    const sidebar = document.getElementById('sidebar');
    const mainContent = document.getElementById('mainContent');
    const toggleBtn = document.getElementById('sidebarToggle');
    const sidebarCollapsedContent = document.getElementById('sidebarCollapsedContent');
    const sidebarFullContent = document.getElementById('sidebarFullContent');


    const collapsed = localStorage.getItem('SideBarCollapsed') === 'true';

    if (collapsed) {
        sidebar.style.width = '80px';
        mainContent.style.marginLeft = '80px';
        sidebarCollapsedContent.style.display = 'flex';
        sidebarFullContent.style.display = 'none';
    }
    else {
        sidebar.style.width = '280px';
        mainContent.style.marginLeft = '280px';
        sidebarCollapsedContent.style.display = 'none';
        sidebarFullContent.style.display = 'flex';
    }

    function toggleSidebar(){
        console.log("button clicked");
        const isCollapsed = sidebarCollapsedContent.style.display === 'flex';
        if (isCollapsed) {
            sidebar.style.width = '280px';
            mainContent.style.marginLeft = '280px';
            sidebarCollapsedContent.style.display = 'none';
            sidebarFullContent.style.display = 'flex';
            localStorage.setItem('SideBarCollapsed', 'false');
        }
        else {
            sidebar.style.width = '80px';
            mainContent.style.marginLeft = '80px';
            sidebarCollapsedContent.style.display = 'flex';
            sidebarFullContent.style.display = 'none';
            localStorage.setItem('SideBarCollapsed', 'true');
        }
    }

    toggleBtn?.addEventListener('click', toggleSidebar);
})

/*Sidebar collapsing js code ends............................................... */