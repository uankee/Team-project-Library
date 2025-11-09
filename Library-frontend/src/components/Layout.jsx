import React from 'react';
import { Breadcrumb, Layout, Menu, theme } from 'antd';
import { Link, Outlet } from 'react-router-dom';
import {
    HomeFilled,
    AlignLeftOutlined,
    BookOutlined
} from '@ant-design/icons';
const { Header, Content, Footer } = Layout;

const items = [
  
    { 
        key: '/',
        label: <Link to="/">Home</Link>,        
        icon: <HomeFilled />
    },
    { 
        key: 'rental_history',
        label: <Link to="rental_history">Rental History</Link>,
        icon: <AlignLeftOutlined />
    },
    { 
        key: 'my_books',
        label: <Link to="my_books">My Books</Link>,
        icon: <BookOutlined />
    }
];

const AppLayout = () => {
  const {
    token: { colorBgContainer, borderRadiusLG },
  } = theme.useToken();

  return (
    <Layout style={{ minHeight: '100vh', width: '100vw' }}>
      <Header
        style={{
          position: 'sticky',
          top: 0,
          zIndex: 1,
          width: '100%',
          display: 'flex',
          alignItems: 'center',
          background: 'transparent',
          position: 'absolute',
          top: '0',
          left: '0',
        }}
      >
        <h2 style={{ color: 'white', marginRight: 24 }}>Library Books</h2>
        <Menu
          theme="dark"
          mode="horizontal"
          defaultSelectedKeys={['1']}
          items={items}
          style={{ flex: 1, background: 'transparent', color: 'black' }}
        />
      </Header>

      <Content style={{background: colorBgContainer }}>
        <div
          style={{
            background: colorBgContainer,
            minHeight: 'calc(100vh - 160px)',
            borderRadius: borderRadiusLG,
            width: '100%',

          }}
        >
          <Outlet />
        </div>
      </Content>

      <Footer
        style={{
          textAlign: 'center',
          background: '#001529',
          color: 'white',
          padding: '16px 0'
        }}
      >
        Library ©{new Date().getFullYear()} Created Team №4
      </Footer>
    </Layout>
  );
};

export default AppLayout;
