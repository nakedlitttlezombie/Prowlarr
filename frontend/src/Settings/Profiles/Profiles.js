import React, { Component } from 'react';
import { DndProvider } from 'react-dnd';
import { HTML5Backend } from 'react-dnd-html5-backend';
import PageContent from 'Components/Page/PageContent';
import PageContentBody from 'Components/Page/PageContentBody';
import SettingsToolbarConnector from 'Settings/SettingsToolbarConnector';
import translate from 'Utilities/String/translate';
import AppProfilesConnector from './App/AppProfilesConnector';
// Only a single DragDrop Context can exist so it's done here to allow editing
// App profiles and reordering delay profiles to work.

class Profiles extends Component {

  //
  // Render

  render() {
    return (
      <PageContent title={translate('Profiles')}>
        <SettingsToolbarConnector
          showSave={false}
        />

        <PageContentBody>
          <DndProvider backend={HTML5Backend}>
            <AppProfilesConnector />
          </DndProvider>
        </PageContentBody>
      </PageContent>
    );
  }
}

export default Profiles;
